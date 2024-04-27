/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) {
  let result = 0;
  s = s + " ";
  for (let i = 0; i < s.length; i++) {
    const next = s[i + 1];
    switch (s[i]) {
      case "I":
        if (!["V", "X"].includes(next)) {
          result++;
        } else {
          result--;
        }
        break;
      case "V":
        result += 5;
        break;
      case "X":
        if (!["L", "C"].includes(next)) {
          result += 10;
        } else {
          result -= 10;
        }
        break;
      case "L":
        result += 50;
        break;
      case "C":
        if (!["D", "M"].includes(next)) {
          result += 100;
        } else {
          result -= 100;
        }
        break;
      case "D":
        result += 500;
        break;
      case "M":
        result += 1000;
        break;
    }
  }

  return result;
};
