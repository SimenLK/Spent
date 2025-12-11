# Install just: https://github.com/casey/just

set dotenv-load

src_path := "src"
test_path := "test"

dist_path := "dist"

# Default recipe - show available commands
default:
    @just --list

# Clean build artifacts
clean:
    rm -rf {{dist_path}}

# Build production bundle
bundle: clean bundle-cli

bundle-cli:
    dotnet build -tl -c Release -o {{dist_path}} {{src_path}}

# Build debug bundle
bundle-debug: clean bundle-cli-debug

bundle-cli-debug:
    dotnet build -tl -c Debug -o {{dist_path}} {{src_path}}

# Format code with Fantomas
format:
    fantomas {{src_path}} -r

# Run tests
test: clean test-cli

test-cli:
    dotnet run {{test_path}}/Tests