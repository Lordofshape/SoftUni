function solve(a,b){
    let maxNum = Math.max(a,b);
    let minNum = Math.min(a,b);
    do {
       maxNum = maxNum - minNum;
       if (maxNum<minNum) {
           const max = minNum;
           minNum = maxNum;
           maxNum = max;
       }
    } while (minNum>0);
    console.log(maxNum);
}

solve(2154, 458);