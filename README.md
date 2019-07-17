# Game

GitHub is an online application that can be used to share files and work on projects collaboratively. It is an application that is easy to git(get), learn, and use.

GitHub runs online, thus nothing needs to be installed for it to be used, other than the Git application, which comes with a command prompt, but is only necessary for the commands that it allows you to run in WindowsPowershell (Powershell is easier and nicer to use than the Git command line interface).



#### INSTALL AND USE GIT FOR THE FIRST TIME ####

1. Install Git using this install link: https://gitforwindows.org/

2. After installing git, navigate to the Git project website: https://github.com/dragmarim/Game

3. On this website, select the "Clone or download" button and copy the url in the box that appears.

4. Next, run the `git clone GIT_INSTALL_LINK_HERE` command in the Powershell. This will install the GitHub project folder in your local User folder.

5. In order to access/edit the folder, open Unity, select the option to open an existing project, and then navigate to the folder that the clone command installed (Path: C:\Users\YOUR_PC_USER_NAME).



#### INSTALL POSH-GIT ####
(SUGGESTED) Install directions for the Posh-Git script can be found at this link: https://github.com/dahlbyk/posh-git.

1. Open Powershell and run this command: `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser -Confirm` (Answer 'Y' if this brings up a bunch of text asking whether you want to do this).

2. Next, run this command: `PowerShellGet\Install-Module posh-git -Scope CurrentUser -Force` (Answer 'Y' if this brings up a bunch of text asking to install another program, then run this command again).

3. In Powershell, navigate to your Git project folder directory (using `cd` and `dir`) and then run the `Import-Module posh-git` command.

Posh-Git provides extra details for Git branches that show you how many changes that you've made, and how different your branch is from the main branch.



#### CREATING A GIT BRANCH ####
After installing the project, you can make changes to the project in Unity at any point in time, but I strongly suggest using branches for each of your changes. Once you have an idea of what you would like to add/make, follow these steps:

0. REMEMBER: ALWAYS CREATE BRANCHES FROM THE MASTER BRANCH! (I will start using feature branches later)

1. Make sure that you are in the "master" branch (posh-git will show a message like: [master = -0 -0 -0] in Powershell next to your current path). If you have gone to a different branch, you can run this command to return to the master branch: `git checkout master`.

2. Run the `git pull` command to pull down changes made by others and ensure that your master branch is up-to-date.

3. Decide what you would like to name your branch (i.e. "Add-Racing-Items" or "Redo-Main-Menu"). It is common practice to replace whitespace with dashes in branch names, so try and remember to do that.

4. Run the following command (FROM THE MASTER BRANCH): `git checkout -b YOUR-BRANCH-NAME-HERE`.

Now you will be in your own branch, which you can make changes from. If you leave this branch and want to return to it, run the `git checkout YOUR-BRANCH-NAME-HERE` command.



#### GIT COMMITS ####
Once you make changes to the project and would like to submit these changes, you will have to submit your changes to GitHub. To do this, follow these steps:

1. Checkout the master branch and pull down any changes (see commands above).

2. Checkout your current branch and run the following command to make sure that your current branch is up to date: `git merge master`.

3. Resolve any code conflicts. With proper management, conflicts should not occur often. If conflicts do occur, however; communicating with other team members will be a good idea to make sure that the conflicts are resolved and nothing important is removed.

4. Once you are satisfied with your branch and it is up to date, run the `git add .` command to add all of your changes, or if you have files that you do not want to commit, just run `git add FILE-NAME-HERE` for each file that you would like to add to your commmit.

5. Once you have added all of the files that you would like to commit, run the `git commit` command. This will open the VIM editor. Look up a tutorial if you get stuck, but otherwise, you can use these general commands to interact with it:
'i' = Insert: Start editing the text (can't use commands until using 'esc').
'esc' = Exit: Stop editing the text.
':wq' = Write/Quit: Open the VIM menu with ':' and type 'wq' to save and exit.

Type a short and concise commit message that will be helpful for others to understand what your commit is changing/adding (i.e. "Added a mushroom and star item" or "Fixed the invisible wall glitch"). Use the ':wq' command to exit and save after finishing your message.

6. After typing your message, run the `git push` command to push your changes up to the GitHub project website.



#### PULL REQUESTS ####
Pull requests are used to finalize changes that have been committed to GitHub. Once a commit is sent to GitHub, you simply navigate to the changes and then select the option to open a pull request. The GitHub project admins (currently just me) will review the pull request and request that you make any necessary changes, or they will merge your changes into the master branch. If the admin(s) request changes, you will have to return to your branch, make these changes, and then commit/push them to GitHub to be reviewed again. Email notifications should be sent to your email address automatically when changes are requested or merged with the master branch, but the GitHub emails may be marked as spam (make sure that they are not marked as spam!).



#### VSCODE ####
(SUGGESTED) Unity comes with MonoDevelop and Visual Studio as text editors (which you may use if you like these editors), but I recommend using VSCode, as it is free, lightweight, and very easy to customize.

Install VSCode here: https://code.visualstudio.com/

After installing and opening VSCode, use the navigation bar on the left side of the application to open the "Extensions" menu. Look up "Unity" and you will find various useful plugins such as "Debugger for Unity", "Unity" Tools", and "Unity Code Snippets".



#### REVIEW ####
After installing Git and setting everything up, you will generally only have to follow the following steps if you would like to contribute to developing the project:

1. Pull changes and update your master and current named branches.

2. Make changes to the Unity project.

3. Pull changes and update your master and current named branches (again).

4. Resolve conflicts.

5. Add desired changes to a commit.

6. Commit the changes with a descriptive name.

7. Push the changes to GitHub.

8. Open a pull request for your changes to be merged with the master project file.

9. Repeat for any changes that you would like to make.

10. Have fun and learn how to design games as a group!
