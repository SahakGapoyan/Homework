#!/bin/bash

#region 1
ls /etc | grep '[0-9]'
#endregion

#region 2
echo -e "Hello\nWorld\nTestlo\nHillo\nOtherlo\n" >test_file.txt
grep -E '\b\w{3}lo$' test_file.txt
#endregion

#region 3
grep -h '[A-Z]' список_каталогов*.txt:  # Որոնում է առնվազն մեկ մեծատառ պարունակող տողեր:
grep -h '[-AZ]' список_каталогов*.txt:  # Որոնում է «-», «A» կամ «Z» նիշերից որևէ մեկը պարունակող տողեր:
grep -h '^[A-Z]' список_каталогов*.txt: # Որոնում է մեծատառով սկսվող տողեր:
grep -h '[^A-Z]' список_каталогов*.txt: # Որոնում է տողեր, որոնք պարունակում են մեծատառերից բացի որևէ այլ նիշ:
#endregion

#region 4
grep -E '^(bz|zip)' dirlist-bin.txt dirlist-sbin.txt
#endregion

#region 5
grep -Eh '^(bz|gz|zip)' список_каталогов*.txt # Փնտրում է «bz», «gz» կամ «zip» տողեր:
grep -Eh '^bz|gz|zip' список_каталогов*.txt   # Որոնում է «bz»-ով սկսվող կամ «gz» կամ «zip» պարունակող տողեր:
#endregion

#region 6
echo "test@test.com" | grep -E '^([a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,})$'
#endregion

#region 7
echo "192.168.0.1" | grep -E '^([0-9]{1,3}\.){3}[0-9]{1,3}$'
#endregion

#region 8
# Կարճ ասած չգիտեմ։ Մի 35 րոպե ա փորձում եմ, չի լինում ու չգիտեմ խի
#endregion

#region 9
echo "01/02/1970" | sed -E 's~([0-9]+)/([0-9]+)/([0-9]+)~\3-\2-\1~'
#endregion

#region 10
echo "0xx 12-34-56" | sed -E 's~^(0xx) ([0-9]{2})-([0-9])([0-9])-([0-9]{2})$~(\1) \2\3-\4\5~'
#endregion