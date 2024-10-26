#!/bin/python3

import math
import os
import random
import re
import sys


#
# Complete the 'balancedSums' function below.
#
# The function is expected to return a STRING.
# The function accepts INTEGER_ARRAY arr as parameter.
#

def balancedSums(arr):
    if len(arr) == 1:
        return "YES"
    else:
        left_sum = 0
        right_sum = sum(arr)

        for i in range(len(arr)):
            right_sum -= arr[i]
            if right_sum == left_sum:
                return "YES"
            else:
                left_sum += arr[i]
        return "NO"

if __name__ == '__main__':
    T = int(input().strip())

    for T_itr in range(T):
        n = int(input().strip())

        arr = list(map(int, input().rstrip().split()))

        result = balancedSums(arr)

        print(result)
