import {FC} from "react";
import {Link} from "react-router-dom";
import {ILinkBase} from "@src/shared/ui/link/type/LinkType";
import linkBrand from "@src/shared/ui/link/link-brand/linkBrand.module.scss"

export const LinkBrand: FC<ILinkBase> = (props) => {
    const {to, children, className} = props;
    return (
        <Link to={to} className={linkBrand.brand_card}>
            {children}
        </Link>
    );
};