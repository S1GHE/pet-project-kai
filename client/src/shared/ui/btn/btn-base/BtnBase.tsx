import {FC} from "react";
import {IBtnBase} from "@src/shared/ui/btn/types/btnType";
import cls from "@src/shared/ui/btn/btn-base/btnBase.module.scss";
import {useClass} from "@src/shared/hooks";

export const BtnBase:FC<IBtnBase> = (props) => {
    const {
        children, onClick, state="white"
    } = props;

    return (
        <button onClick={onClick} className={useClass([
            cls.main_btn, cls[state]
        ])}>
            {children}
        </button>
    );
};