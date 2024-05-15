import bgImage from "@src/shared/assets/widgets/40bf2396899cdaa2d0f1.webp";
import classes from "@src/widgets/cards/login-account/loginAccount.module.scss";
import {TextModule} from "@src/shared/scss";
import {BtnBase} from "@src/shared/ui/btn";
import {BgModal} from "@src/shared/ui/modal";
import {useState} from "react";

export const LoginAccount = () => {
    const [isModal, setIsModal] = useState<boolean>(false)

    return (
        <>
            {isModal && <BgModal state={{isActive: isModal, setIsActive: setIsModal}}>
                div
            </BgModal>}
            <div className={classes.card_container}>
                <div className={classes.card_wrapper}>
                    <div className={classes.card_text}>
                        <h6 className={TextModule.p18__bold}>Личный кабинет</h6>
                        <p className={TextModule.p14}>Получайте бонусы, отслеживайте заказы и делитесь мнением.</p>
                    </div>

                    <div className={classes.card_btn}>
                        <BtnBase onClick={() => setIsModal(!isModal)}>
                            <p className={TextModule.p14}>Войти</p>
                        </BtnBase>

                        <BtnBase onClick={() => setIsModal(!isModal)}>
                            <p className={TextModule.p14}>Мои заказы</p>
                        </BtnBase>
                    </div>
                </div>

                <div className={classes.card_img}>
                    <img src={bgImage} alt={bgImage}/>
                </div>
            </div>
        </>
    );
};