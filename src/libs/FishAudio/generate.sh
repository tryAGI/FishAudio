#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

curl -o openapi.json https://docs.fish.audio/api-reference/openapi.json

# Auth: --security-scheme ensures AutoSDK generates Bearer constructors.
# The Fish Audio spec already uses http/bearer securitySchemes but lacks top-level security array.
autosdk generate openapi.json \
  --namespace FishAudio \
  --clientClassName FishAudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
