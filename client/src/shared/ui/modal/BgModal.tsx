import cls from "@src/shared/ui/modal/BgModal.module.scss";
import {Dispatch, FC, ReactNode, SetStateAction} from "react";

export interface IBgModal {
    children: ReactNode
    state: {
        isActive: boolean
        setIsActive: Dispatch<SetStateAction<boolean>>
    }
}

export const BgModal:FC<IBgModal> = (props) => {
    const {
        children, state
    } = props;

    const clickHandler = () => {
        state.setIsActive(!state.isActive)
    }

    return (
        <div className={cls.bg_modal} onClick={clickHandler}>
            {children}
        </div>
    );
};