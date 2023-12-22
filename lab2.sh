#region 1
cat > file1 # Ստեղծում է ֆայլ file1. և սպասում է ստեղնաշարի մուտքագրմանը մինչև Ctrl+D մուտքագրվի: Մուտքագրված տեքստը կգրվի file1-ում:
cat file1 # Ցուցադրում է file1-ի բովանդակությունը:
cat < file1 # Ցուցադրում է file1-ի բովանդակությունը:
#endregion

#region 2
cat > file1.txt
cat > file2.txt
cat > file3.txt
cat file1.txt file2.txt file3.txt > Final.txt
#endregion

#region 3
ls ./*.txt | wc -l
#endregion

#region 4
cat file1.txt file2.txt file3.txt | sort > sorted.txt
#endregion

#region 5
ls -S ./ | head -n 15
#endregion

#region 6
ls ./ > ls.txt
#endregion

#region 7
echo "secret text" | tr 'a-zA-Z' 'n-za-mN-ZA-M'
echo "frperg grkg" | tr 'a-zA-Z' 'n-za-mN-ZA-M'
#endregion

#region 8
echo "Student’s home directory is {home_dir}." > home.txt
sed 's/{home_dir}/\/home\/student/' home.txt > home_modified.txt
#endregion

#region 9
echo "Line 1" > file4.txt
echo "Line 2" >> file4.txt
echo "Line 3" >> file4.txt
echo "Line 4" >> file4.txt
echo "Line 5" >> file4.txt
sed -n '2p;4p' file4.txt
#endregion

#region 10
sed -i '2d;4d' file4_modified.txt
#endregion