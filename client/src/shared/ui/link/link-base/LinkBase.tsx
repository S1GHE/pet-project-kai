import {FC} from "react";
import {Link} from "react-router-dom";
import {ILinkBase} from "@src/shared/ui/link/type/LinkType";
import classes from "@src/shared/ui/link/link-base/baseLink.module.scss";
import {useClass} from "@src/shared/hooks";

export const LinkBase: FC<ILinkBase> = (props) => {
    const {to, children, className} = props;

    return (
        <Link to={to} className={useClass([classes.base_link, className])}>
            {children}
        </Link>
    );
};
