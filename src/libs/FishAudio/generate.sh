#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://docs.fish.audio/api-reference/openapi.json
install_autosdk_cli

rm -rf Generated

fetch_spec --fail --silent --show-error -L -o openapi.json https://docs.fish.audio/api-reference/openapi.json

# Auth: --security-scheme ensures AutoSDK generates Bearer constructors.
# The Fish Audio spec already uses http/bearer securitySchemes but lacks top-level security array.
autosdk generate openapi.json \
  --namespace FishAudio \
  --clientClassName FishAudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/FishAudio.CLI

autosdk cli-project openapi.json \
  --output ../../cli/FishAudio.CLI \
  --sdk-project ../../libs/FishAudio/FishAudio.csproj \
  --targetFramework net10.0 \
  --namespace FishAudio \
  --clientClassName FishAudioClient \
  --package-id FishAudio.CLI \
  --tool-command-name fish-audio \
  --user-secrets-id FishAudio.CLI \
  --api-key-env-var FISHAUDIO_API_KEY \
  --base-url-env-var FISHAUDIO_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
