# DotNet.EntityAttributeValue

This repository is the base source for libraries that implement the _Entity Attribute Value_ design pattern to c# (.net7).

The repository lies on several submodules for different libraries.

## Libraries

| Name | Description |
| - | - |
| `Kuchulem.DotNet.EntityAttributeValue.Abstractions` | Interfaces and abstract classes used to work with the EAV Implementations. All libraries in the `Kuchulem.DotNet.EntityAttributeValue` namespace __MUST__ depends on this one, and __SHOULD NOT__ depend on any other from the same namespace. |
| `Kuchulem.DotNet.EntityAttributeValue.Converters` | Implementations of converters abstractions. Can be added to your projects to implement simple converters for most common types. |
| `Kuchulem.DotNet.EntityAttributeValue.EntityFrameworkCore` | Support of EAV for EntityFrameworkCore. | 

## Usage

See the `README.md` for each library.

## Contributing

### Gets the sources

Get the main project and ots submodules :

```sh
git clone git@github.com:Kuchulem/DotNet.EntityAttributeValue.git
cd Kuchulem/DotNet.EntityAttributeValue
# init submodules
git submodule init
# fetch the submodules
git submodule update
```

### Submodules description

| Path | GitHub Repository | Library |
| ---- | ---------- | ----------- |
| `src/Abstractions` | [Link](https://github.com/Kuchulem/DotNet.EntityAttributeValue.Abstractions) | The `Kuchulem.DotNet.EntityAttributeValue.Abstractions` library provides all the interfaces and abstract classes needed to work with the EAV pattern implementations. |
| `src/Converters` | [Link](https://github.com/Kuchulem/DotNet.EntityAttributeValue.Converters) | The `Kuchulem.DotNet.EntityAttributeValue.Converters` library provides implementations of convertion abstractions. The repository also contains un test project for that library. |
| `src/EntityFramework` | [Link](https://github.com/Kuchulem/DotNet.EntityAttributeValue.EntityFrameworkCore) | `Kuchulem.DotNet.EntityAttributeValue.EntityFrameworkCore` |

### Comiting

Modifications should only come to a library repository, not the main (`Kuchulem.DotNet.EntityAttributeValue`) repo.

Push your modifications to a new branch, following thoses rules :

1. A branch name MUST start with `fix/` or `feature/`
   - `fix/` : if you apply a fix to the project
   - `feature/` : if you add a new feature
2. A branch name MUST contain an explicit and concise description of you work in `kebab-case`. ie : `feature/mongo-db-support`, `fix/string-converter-not-supporting-diacritics`

Once pushed create a pull request to the `main` branch, linked to the corresponding issue(s), if any.