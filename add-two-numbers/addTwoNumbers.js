/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function (l1, l2) {
  let result;
  let carryOver = false;
  const addNode = function (sum) {
    if (carryOver) {
      sum++;
    }
    let newNode = new ListNode(sum % 10);
    carryOver = sum >= 10;
    if (!result) {
      result = newNode;
      previous = newNode;
    } else {
      previous.next = newNode;
      previous = newNode;
    }
  };

  while (l1 || l2) {
    let sum = 0;
    if (l1 && l2) {
      addNode(l1.val + l2.val);
      l1 = l1.next;
      l2 = l2.next;
    } else if (l1) {
      addNode(l1.val);
      l1 = l1.next;
    } else if (l2) {
      addNode(l2.val);
      l2 = l2.next;
    }
  }
  if (carryOver) {
    previous.next = new ListNode(1);
  }

  return result;
};
