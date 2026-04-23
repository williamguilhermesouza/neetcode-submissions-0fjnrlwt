func twoSum(numbers []int, target int) []int {
    begin := 0
    end := len(numbers) - 1

    for begin < end {
        sum := numbers[begin] + numbers[end]
        if sum == target {
            return []int{ begin +1, end +1}
        } else if sum < target {
            begin++
        } else {
            end--
        }
    }

    return []int{}
}
