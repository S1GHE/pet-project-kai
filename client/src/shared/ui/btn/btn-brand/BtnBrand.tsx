import { FC } from "react";
import { IBtnBase } from "@src/shared/ui/btn/types/btnType";
import { ILinkBrand } from "@src/shared/ui/link/type/LinkType";

export const BtnBase: FC<ILinkBrand> = ({
  onClick,
  to,
  children,
  className,
}) => {
  return <button
    onClick={onClick}
    className={className}>
        {to}{children}
    </button>;
};
