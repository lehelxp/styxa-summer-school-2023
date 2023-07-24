import { Outlet } from "react-router-dom";
import "./Content.scss";
import background from "../../pngtree-futuristic-shape-abstract-background-chemistry-technology-concept-for-website-picture-image_1250295.jpg"
const Content=()=>{
    return(
        <div className="content" style={{backgroundImage:background}}>
            <Outlet />
        </div>
    )
};

export default Content;