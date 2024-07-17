str = "The quick";
// declare an array with size = sttr.length
let arr = new Array(str.length);

arr[0] = str[0];
for (let i = 1; i < str.length; i++) {
   if (str[i] === " ") {
      arr[i] = str[i];

      arr[i + 1] = str[++1].toUpperCase(); // works
      arr[i + 1] = str[i + 1].toUpperCase(); // does not work 

   } else {
      arr[i] = str[i];
   }

}
console.log(arr.join('')); // The Quick
