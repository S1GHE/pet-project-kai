import React from "react";
import {FC} from "react";
import {ILinkBase} from "@src/shared/ui/link/type/LinkType";
import { Link } from "react-router-dom";

export const LinkBrand: FC<ILinkBase> = (props) => {
    const {to, children, className} = props;
    
    return (
      <button className={className}>
        {children}{to}
      </button>
    );
};
