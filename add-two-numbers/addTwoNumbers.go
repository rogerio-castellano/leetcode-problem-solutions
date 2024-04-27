/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
    var result, newNode, previousNode *ListNode
    var carryOver bool
    var sum int

    var addNode = func (sum int) {
        if(carryOver) {
           sum++ 
        }
        newNode = &ListNode{Val: sum % 10}
        carryOver = sum >=10
        if(result == nil) {
            result = newNode
        } else {
            previousNode.Next = newNode
        }

        previousNode = newNode
    }


    for (l1 != nil || l2 != nil) {
        sum = 0
        if(l1 != nil) {
            sum+= l1.Val
            l1 = l1.Next
        }
        if(l2 != nil) {
            sum+= l2.Val
            l2 = l2.Next
        }
        addNode(sum)
    }

    if(carryOver) {
        previousNode.Next = &ListNode{Val: 1}
    }

    return result
}