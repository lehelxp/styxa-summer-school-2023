import { useState } from "react"

const Counter=()=>{
    const [count,setCount]=useState<number>(0);
    
    const increase=()=>{
        setCount(count+1);
    }
    const decrease=()=>{
        setCount(count-1);
    }
    return(
<div>
<label htmlFor="counter-input">Count</label>
<input id="counter-input" className="text-input" value={count} readOnly />
<button onClick={increase}>+</button>
<button onClick={decrease}>-</button>
</div>

)

}
export default Counter;