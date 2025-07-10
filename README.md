# OldKeyPadProblem

# STEPS and APPROACH to solve

1-first step is to intialize a keyvalue pair to map perticular nnumber to group of character(ex-2:ABC).

2-Now we will split numbercombo by space(space is like 1 second pouse) ex- 443 2 22#. we create an array
string[] numbercombo = input.Split(' ')=[443 2 22];

3- now we will each number and friquency of each number ex- first number is 443 so there are 4 is 2 time and 3 is 1

4- now we calculate count of same number and check that number in keyvalue pair ex- 4 is prresent (4:GHI)
int index = (count - 1) % letters.Length;(index= 2-1%3)
now letter for 4 is GHI but index is 1 means H
result.Append(letters[index]); result=H same for 3 is E

Till now we have calculated first number 4433 from [443 2 22]

Now same for 2(A) and 22(B)

Finally We will get result= HEAB

