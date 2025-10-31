let myString = "This is a string";
let anotherString = "    Another string";
let hello = "Hello there";
let myName = "Jed";

console.log(myString);
console.log(anotherString);
console.log(hello);
console.log(myName);

console.log(myString.length);
console.log(myString.charAt(0));
console.log(myString.charAt(10));

console.log(myString.slice(5, 9));
console.log(myString.substring(6, 9));

console.log(myName.toUpperCase());
console.log(myName.toLocaleLowerCase());

console.log(hello.concat(myName));
console.log(anotherString.trim());
console.log(myString.replace("is a ", " "));
console.log(myString.split(" "));