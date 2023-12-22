#!/bin/bash

#region 1
touch file.txt
chmod 744 file.txt
#endregion

#region 2
chmod a+x file.txt
#endregion

#region 3
chmod go-x file.txt
#endregion

#region 4
chmod 600 file.txt
#endregion

#region 5
mkdir dir
chmod 666 dir
touch dir/file.txt
#endregion

#region 6
touch dir/file1.txt dir/file2.txt
chmod 766 dir/*
#endregion

#region 7
umask 027
#endregion

#region 8
umask 077
umask 022
#endregion

#region 9
echo 'ls /home/student' > script.sh
chmod 741 script.sh
./script.sh
chmod +x script.sh
#endregion

#region 10
mkdir ~/bin
mv script.sh ~/bin
echo 'export PATH=$PATH:~/bin' >> ~/.bashrc
source ~/.bashrc
#endregion