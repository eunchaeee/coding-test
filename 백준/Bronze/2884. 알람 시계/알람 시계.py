a, b = map(int,input().split())
alarm = (60*a+b)-45
if alarm<0:
    alarm = alarm+24*60
    
print(alarm // 60, alarm%60)