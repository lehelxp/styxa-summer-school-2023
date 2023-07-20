import { useEffect, useRef, useState } from "react";
import TextField from "../TextField/TextField";
import Button from "../Button/Button";

interface TodoItem{
  id:number,
  label:String,
    checked:Boolean,
  }
const TodoList = () => {
  
  const [todos, setTodos] = useState<TodoItem[]>([]);
  const [text, setText] = useState<string>("");

  const handleAddClick = () => {
    setTodos([...todos,{
      id: Math.random(),
      label:text,
      checked:false,
    }])
  };

  const handleRemoveClick = (id:number) => {
    setTodos(todos.filter((todo)=>todo.id!==id))
  };
  useEffect(() => {
    //backend call
  }, [todos]);

  useEffect(() => {
    console.log("mount");

    //backend call
  }, []);

  return (
    <div>
      <TextField label="Todo" onChange={setText} />
      <Button onClick={handleAddClick}>Add todo</Button>
      <ul>
        {todos.map((item, index) => {
          return <li key={index}>
              <span>{item.label}</span>
          <Button onClick={()=>handleRemoveClick(item.id)}>x</Button>
          </li>;
        })}
      </ul>
    </div>
  );
};

export default TodoList;
