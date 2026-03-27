#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

curl -o openapi.json https://docs.fish.audio/api-reference/openapi.json

# The Fish Audio spec already uses http/bearer securitySchemes.
# Add top-level security array for AutoSDK to generate Bearer constructors.
jq '.security = [{"BearerAuth": []}]' openapi.json > openapi_fixed.json
mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace FishAudio \
  --clientClassName FishAudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
