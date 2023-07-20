import { styled } from "styled-components";
import { FC, useContext, useEffect, useState } from "react";
//import "./TextField.scss";
import { UserContext } from "../../context/UserContext";

//const FieldWrapper = styled("div")`
//  background-color: green;
//`;

interface TextFieldProps {
  value?: string | number;
  label: string;
  onChange?: (value: string) => void;
}

const TextField: FC<TextFieldProps> = ({ label, onChange, value = "" }) => {
  const [inputText, setInputText] = useState<string | number>();

  const { loggedIn } = useContext(UserContext);

  const handleTextChange = (text: string) => {
    setInputText(text);
    onChange?.(text);
  };

  useEffect(() => {
    setInputText(value);
  }, [value]);

  console.log("ittt", loggedIn);

  return (
    <div>
      <label htmlFor="my-input">{label}: </label>
      <input
        id="my-input"
        className="text-input"
        onChange={(event) => handleTextChange(event.target.value)}
        value={inputText}
      />
    </div>
  );
};

export default TextField;
