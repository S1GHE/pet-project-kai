import {ReactNode} from "react";

export interface ILinkBase {
    to: string;
    children: ReactNode | string;
    className?: string | undefined;
    onClick?: () => void | undefined;
}