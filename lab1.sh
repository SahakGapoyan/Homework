#region 1
mkdir lab1
cd lab1
touch file.txt file1.txt file2.txt file3.txt
mkdir dir1 dir2
#endregion

#region 2
ls *.txt # ման ա գալի *.txt ֆայլերը
ls * .txt # ման ա գալի ինչ-որ .txt ֆայլ ¯\_(ツ)_/¯
#endregion

#region 3
ls f???.txt
#endregion

#region 4
ls file[0-9]*.txt
#endregion

#region 5
ls *[a-z0-1].txt
#endregion

#region 6
cp /etc/passwd lab1/
#endregion

#region 7
mv lab1/passwd lab1/new
mv lab1/new lab1/dir1/
mv lab1/dir1/new lab1/dir2/
#endregion

#region 8
mv ./dir2 ./dir3
mv ./dir3 ./dir1/
#endregion

#region 9
mv ./dir1/new ./
#endregion

#region 10
rm -r lab1
#endregion
