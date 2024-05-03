import {FC} from "react";
import {Link} from "react-router-dom";
import {ILinkBase} from "@src/shared/ui/link/type/LinkType";

export const LinkBase: FC<ILinkBase> = (props) => {
    const {to, children} = props;

    return (
        <Link to={to}>
            {children}
        </Link>
    );
};
