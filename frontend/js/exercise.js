const textField=document.getElementById("my-input");
const addButton=document.getElementById("add-button");
const todoList=document.getElementById("todo-list");
let todos=[];

const displayListItem=(text)=>{
    const item=document.createElement("li");
    item.innerHTML=text;
    const deleteButton=document.createElement("button",);
    deleteButton.innerHTML="x";
    deleteButton.addEventListener("click",()=>{item.remove()});
    item.append(deleteButton);
    todoList.append(item);
}
const displayTodoList=()=>{
    todos.forEach((text)=>{
        displayListItem(text);
    })
}
addButton.addEventListener("click",()=>{
    todos.push(textField.value);
    //console.log(textField.value);
    //const item=document.createElement("li");
    //item.innerHTML=textField.value;
    //todoList.append(item);
    displayListItem(textField.value);
    textField.value="";
});
textField.addEventListener("keyup",(event)=>{
    if(event.keyCode===13){
        todos.push(textField.value);
        displayListItem(textField.value);
        textField.value="";
    }
})
displayTodoList();
//const displayTodoList=()=>{};