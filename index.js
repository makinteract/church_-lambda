const TRUE = (x) => (y) => x;
const FALSE = (x) => (y) => y;
const IF = (b) => (x) => (y) => b(x)(y);
const LT = (a, b) => (Math.sign(a - b) === -1 ? TRUE : FALSE);

// Main function

console.log('Ready');

const result = IF(LT(1, 2))('less')('not less');
console.log(result); // Output: "less"

const result2 = IF(TRUE)(1)(2);
console.log(result2); // Output: 1
