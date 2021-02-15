# Coverage Sample

## Summary

This solution demonstrates that no coverage data is obtained for a project who's code is under test but also references a source generator.

The source generator used here is a very simple hello world string generator obtained from the Roslyn cookbook.

## Running the sample

1. Pull the repository locally and change directory to the local repo folder.
2. Start a powershell terminal and run `.\coverlet-coverage.ps1`.  This script merely runs the tests with coverage enabled.

## Analysis

The coverage results will show HelloWorld2 is covered 100% however HelloWorld does not appear in any result.
