"""
02. 곱하기 혹은 더하기
"""

nums = list(map(int, input()))
total = nums[0]
for i in range(1, len(nums)):
    if nums[i] == 0 or nums[i-1] == 0:
        total += nums[i]
    else:
        total *= nums[i]
print(total)