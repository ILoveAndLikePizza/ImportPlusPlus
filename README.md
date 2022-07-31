# Import++
<img src="/static/icon.png" width="125"><br><i>The Import++ icon</i><br><br>
<img src="/static/mainwindow.png" width="500"><br><i>The Import++ main window</i><br><br>

Import++ is a free and open-source tool to import files from e.g. an external drive, including the feature to automatically rename and number them.
> **Note**: This program works on Windows operating systems only.
## Installing
Just run the EXE file you can find in the [releases](https://github.com/ILoveAndLikePizza/ImportPlusPlus/releases)!
## Usage example
Alright, so let's assume we have a directory `C:\Import++\from_directory`, containing these files:  
![Image](/static/filelist.png)  
...and you want to import the files `test.file_0002.txt` to `test.file_0006.txt` into `C:\Import++\to_directory`:

- Set the [Import files from] field to the directory where files are imported from by using the [Browse...] button. Here it's `C:\Import++\from_directory`;
- Set the [File name format] field to the current format of your files. Here, it is `test.file_****.txt`. As you see, all numbers, including leading zeros, have been replaced by *;
- Set the [From] and [Until (included)] fields to numbers you just replaced by * you want to import, without leading zeros. Over here, we start at 2 and end at 6. That last file will be imported too;
- Set the [Rename files to] field to whatever you want the files to be named when they get imported. Just enter a name for them, the numbers behind will follow soon;
- Set the [Start at] field to the number where the program should start renaming the imported files. Starting at 1 is recommended, however we start at 15 to clarify the difference between the original and imported files. If you want to complement an earlier import, this might be very useful;
- Set the [Number format] box to the desired format in which the numbers will be displayed, like `New Filename 15.txt`, `New Filename (15).txt` or `New Filename - 15.txt`;
- Set the [Save imported files to] field to the output directory by using the [Browse...] button, here it's `C:\Import++\to_directory`;
- Finally, determine if you want already existing files to be overwritten. Here, we'll just leave it on.

When that's done, the window will look like this:  
<img src="/static/mainwindow_filled.png" width="500">  
You're all set! You can click the [Start!] button to begin with importing. You will get one more check if the queried files can be found in the specified directory, and if so, how many of them. When the process is finished, this message box will show up:  
![Image](/static/finished.png)  
And the output directory will look like this:  
![Image](/static/filelist_imported.png)  
And those are the files you just imported!
# Have fun using Import++!
