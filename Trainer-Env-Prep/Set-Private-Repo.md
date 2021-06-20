# How to store all the files in private repo
- Create Repo on GitLab

- Make sure to specify explicit push remte every time
```
git config --global push.default nothing
```

- Create new branch
```
git checkout -b am1
git status
```

- From .gitignote, remove few entries for files which can be stored in private repo
```
notepad .\.gitignore
```

- Add origin of private git repo and push the code to private git repo
```
git remote add gitlab-origin git@gitlab.com:atin-trainings/quatrain-azure-developer-june-21.git
git push -u gitlab-origin master
git add *
git commit -am "-"
git push -u gitlab-origin am1
git checkout master
```

- Now rename the origin name of public repo so that engineer will not git push private branch to public repo
```
git remote rename origin github-origin
git push github-origin master
git pull; git add *; git commit -am "-"; git push github-origin master
```

<<<<<<< HEAD
=======
- Merge the change from master to am1
- Note: Never do the reverse else private files will be uploaded to public repo as .gitignore will be changed
```
git checkout am1
git merge master
del .gitignore
copy .gitignore-gitlab .gitignore
```

>>>>>>> 00095467f7d3b6a22ab75fbda145ba07d9c54003

- In case we need to remove private files from public repo:
```
git rm -r --cached .
git add *
git commit -am "-"
git push github-origin master
```


- Push to public repo (Github)
```
git checkout master
<<<<<<< HEAD
del .gitignore; copy .gitignore-github .gitignore
=======
del .gitignore
copy .gitignore-github .gitignore
>>>>>>> 00095467f7d3b6a22ab75fbda145ba07d9c54003
git pull; git add *; git commit -am "-"; git push github-origin master
```



- Push to private repo (Gitlab)
```
git checkout am1
<<<<<<< HEAD
del .gitignore; copy .gitignore-gitlab .gitignore
=======
del .gitignore
copy .gitignore-gitlab .gitignore
>>>>>>> 00095467f7d3b6a22ab75fbda145ba07d9c54003
git pull; git add *; git commit -am "-"; git push gitlab-origin am1
```
