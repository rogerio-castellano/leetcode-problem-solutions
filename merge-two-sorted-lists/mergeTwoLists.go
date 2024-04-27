/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
    result, current, initialized := &ListNode{}, &ListNode{}, false

    addToResult := func (src *ListNode) {
        if initialized {
            current.Next = src
            current = current.Next
        } else {
            result = src
            current = result
            initialized = true
        }
    }

     for list1 != nil && list2 != nil {
        if(list1.Val < list2.Val) {
            addToResult(list1)
            list1 = list1.Next   
        } else {
            addToResult(list2)
            list2 = list2.Next
        }
    }

    for list1 != nil {
        addToResult(list1)
        list1 = list1.Next   
    }

   for list2 != nil {
        addToResult(list2)
        list2 = list2.Next   
    }

    if(!initialized) {
        return nil
    }

    return result;
}

