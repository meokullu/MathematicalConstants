## MathematicalConstants Changelog
[![MathematicalConstants](https://img.shields.io/nuget/v/MathematicalConstants.svg)](https://www.nuget.org/packages/MathematicalConstants/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [1.4.0]
#### Added
* `ToInt32(string data, int startingIndex, int endIndex)` method added to convert string numerical data into int32 data type.
* `ToInt64(string data, int startingIndex, int endIndex)` method added to convert string numerical data into int64 data type.
* `ToDouble(string data, int startingIndex, int endIndex)` method added to convert string numerical data into double data type.

#### Changed
* Numerical data moved to data.cs under src folder in order to increase exploring performance due to high amount of data.

### [1.3.4]
#### Changed
* Number data moved to `data.cs` which is under `src` folder.

### [1.3.3]
#### Changed
* New design README.
* New design CHANGELOG.

### [1.3.2]
#### Added
* CHANGELOG link added under Version History on README.

#### Changed
* Project folder renamed from MathmaticalConstants to MathematicalConstants.
* Cleaner view on README.
* Tag under PackageTags is changed from Mathematic to Mathematical.

### [1.3.1]
#### Changed
 * Icon was replaced with higher resoulution.

### [1.3.0]
#### Added
* Multi-target frameworks (net6.0; net7.0; net461; netcoreapp3.1; netstandard2.0) support is added.

### [1.2.0]
#### Added
* 40 additional constatans are added.
* Wikipedia, oeis.org, source links are added.
* Added missing length properties.
* Added missing first five digits into summaries. 	  

#### Changed
* Properties are sorted except first six.

### [1.1.0]
#### Added

* 34 additional constants are added.
* Wikipedia links are added to each constant.
* "#.####" format first five digits are added into summaries.

### [1.0.0]
Initial version.
