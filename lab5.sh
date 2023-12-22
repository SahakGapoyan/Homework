#!/bin/bash

#region 1
str="Hello"
echo str2    #str2
echo ${str}2 #Hello2
#endregion

#region 2
echo $((5 ** 2 * 4 / 10))
#endregion

#region 3
echo "The balance for user $USER is: $5,00" # The balance for user root is: ,00
echo "The balance for user $USER: \$5,00"   # The balance for user root: $5,00
#endregion

#region 4
echo '$USER $((2 + 2)) $(ls)' # $USER $((2 + 2)) $(ls)
echo "$USER $((2 + 2)) $(ls)" # root 4 labs main.sh
#endregion

#region 5
current_dir=$(pwd)
num_files=$(ls -l | grep -c "^-")
cat <<EOF
Current directory: $current_dir
Number of files: $num_files
EOF
#endregion

#region 6
sum_numbers() {
	result=$(($1 + $2))
	echo "The summary $1 and $2 is equal to $result"
}

sum_numbers 5 7
#endregion

#region 7
count_files() {
	dir_name=$1
	num_files=$(ls -l $dir_name | grep -c "^-")
	echo "Number of files in the directory $dir_name: $num_files"
}

count_files ./
#endregion

#region 8
touch new_file.txt
if [ -e new_file.txt ]; then
	chmod +rwx new_file.txt
	echo "File new_file.txt has been created, and permissions for read, write, and execute are set."
else
	echo "Error: File new_file.txt was not created."
fi
#endregion

#region 9
find_max() {
	if [ $1 -gt $2 ]; then
		echo "The largest number is: $1"
	else
		echo "The largest number is: $2"
	fi
}

find_max 12 8
#endregion

#region 10
check_even_odd() {
	if [ $(($1 % 2)) -eq 0 ]; then
		echo "$1 is an even number."
	else
		echo "$1 is an odd number."
	fi
}

check_even_odd 7
check_even_odd 8
#endregion
