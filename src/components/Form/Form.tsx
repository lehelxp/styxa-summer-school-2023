import { Button, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, TextField } from "@mui/material";
import { FC, ReactNode } from "react";

interface FormProps{
open:boolean;
handleClose:()=> void;
type:string
handleSubmit: any;
name?:string;
population?:number;
description?:string;
mapsurl?:string;
}

const Form: FC<FormProps>=({open,handleClose,type,handleSubmit, name,population,description,mapsurl})=>{
    return(
        <Dialog open={open} onClose={handleClose}>
        <DialogTitle>{type}</DialogTitle>
        <DialogContent>
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Name"
            type="string"
            fullWidth
            variant="standard"
            value={name}
          />
         {type==="City"&&<TextField
            autoFocus
            margin="dense"
            id="population"
            label="population"
            type="number"
            fullWidth
            variant="standard"
            value={population}
          />}
          <TextField
            autoFocus
            margin="dense"
            id="description"
            label="Description"
            type="string"
            fullWidth
            variant="standard"
            value={description}
          />
            <TextField
            autoFocus
            margin="dense"
            id="mapsurl"
            label="GoogleMaps"
            type="string"
            fullWidth
            variant="standard"
            value={mapsurl}
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>Cancel</Button>
          <Button type="submit" onClick={()=>handleSubmit()}>Submit</Button>
        </DialogActions>
      </Dialog>

    );
};
export default Form;