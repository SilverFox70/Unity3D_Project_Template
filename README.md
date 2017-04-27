# Unity3D Project Template

## Overview
This is a bare bones starter repo for Unity 3D projects. The `.gitignore` and `.gitattribute` files have been configured according to recommended practices which you can find [here](http://www.gamasutra.com/blogs/TimPettersen/20161206/286981/The_complete_guide_to_Unity__Git.php). The **Project Settings** for the editor have been set as follows:
- **Version Control > Mode** is **Visible Meta Files**
- **Asset Serialization > Mode** is **Force Text**

There is also a template script in `Assets/Scripts` for an EventManager.

### Getting Started
For use in your own projects:
1. Fork or clone this repo to your local machine
2. Create a new repository in BitBucket or Github with your own name
3. Set your local to follow your newly created BitBucket repository as "origin":
``` Bash
cd existing-project
git remote set-url origin https://William.Brinkert@bitbucket.akqa.net/scm/~william.brinkert/unity3d_project_template.git
git push -u origin master
```
4. [Install Git LFS](https://help.github.com/articles/installing-git-large-file-storage/)
5. In your existing-project directory, run `git lfs install`
6. Enable SmartMerge by adding the following to your Git config:
``` Bash
[mergetool "unity_yaml"]
cmd = '/Applications/Unity/Unity.app/Contents/Tools/UnityYAMLMerge' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"
trustExitCode = false
keepTemporaries = true
keepBackup = false
 
[merge]
tool = unity_yaml
```
**Note:** on Windows machines replace `/Applications/Unity/Unity.app/Contents/Tools/UnityYAMLMerge` with:
`C:\Program Files\Unity\Editor\Data\Tools\UnityYAMLMerge.exe`
or wherever you installed Unity. For more information on how to use SmartMerge, see [here](http://www.gamasutra.com/blogs/TimPettersen/20161206/286981/The_complete_guide_to_Unity__Git.php).

## Project Structure
- [`/Assets`](./Assets/) - where the majority of Unity assets are stored (scenes, scripts, prefabs)
- [`/Assets/Scripts/`](./Assets/Scripts/) - all C# scripts can be found here

