import os
number = 0
marks = [90, 25, 67, 45, 80]

number = 0
for mark in marks:
    number = number +1
    if mark >= 60:
        print("%d번 학생은 합격입니다." % number)
    else:
        print("%d번 학생은 불합격입니다." % number)

os.system("Pause")
#installer 설치해줘야 됨.
#python 커맨드 창에서 pip install py