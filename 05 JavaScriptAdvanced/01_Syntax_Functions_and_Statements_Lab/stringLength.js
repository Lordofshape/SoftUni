function stringLength() {
    var args = Array.from(arguments)
    var lth = 0;
    var averageLength = 0;
    for (let i = 0; i < args.length; i++) {
        
        lth += args[i].length;
    }
    averageLength += Math.floor(lth/args.length);
    console.log(lth);
    console.log(averageLength);
}