func search(nums []int, target int) int {
    begin, end := 0, len(nums) - 1

    for begin <= end {
        middle := (end - begin) / 2 + begin 

        if nums[middle] < target {
            begin = middle + 1
        } else if nums[middle] > target {
            end = middle - 1
        } else {
            return middle
        }
    }

    return -1
}
