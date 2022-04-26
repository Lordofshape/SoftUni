function largestNumber() {
var args = Array.from(arguments)
var max = args[0];
for (let i = 1; i < args.length; i++) {
    if (args[i]>max) {
        max = args[i];
    }
}
return 'The largest number is ' + max + '.';
}
