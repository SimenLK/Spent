# Spent

A minimal time-tracking tool for logging time in GitLab at the Epic level.

## Build

```
just bundle
cd dist
```

## NixOS

```
nix-build -A default
cd result/bin
./spent --help
```

or

```
nix-shell -A default default.nix
spent
```

## Run

1. Log in to gitlab using `glab auth login`
2. Run `spent ls` to list available epics
2. Log time on epic: `spent time -i 1 -s "stuff" 3h15m`
