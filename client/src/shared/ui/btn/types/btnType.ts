import {ReactNode} from "react";

export interface IBtnBase {
    children: ReactNode;
    onClick?: () => void;
}