function solve([number,area]){
    let speed = number;
    switch (area) {
        case "motorway":
            speed -=130;
            break;
        case "interstate":
            speed -= 90;
            break;
        case "city":
            speed -= 50;
            break;
        default:
            speed -=20;
            break;
    }
    if (speed<=0) {
        
    }
   else if (speed<=20) {
       console.log("speeding");
   } else if(speed<=40) {
       console.log("excessive speeding");
   } else{
       console.log("reckless driving");
   }
}


solve([120, 'interstate']);
