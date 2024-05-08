import bgImage from "@src/shared/assets/widgets/40bf2396899cdaa2d0f1.webp";
import classes from "@src/widgets/cards/login-account/loginAccount.module.scss";
import {TextModule} from "@src/shared/scss";

export const LoginAccount = () => {
    return (
        <div className={classes.card_container}>
            <div className={classes.card_wrapper}>
                <div className={classes.card_text}>
                    <h6 className={TextModule.p18__bold}>Личный кабинет</h6>
                    <p className={TextModule.p14}>Получайте бонусы, отслеживайте заказы и делитесь мнением.</p>
                </div>

                <div className={classes.card_btn}>
                    <button className={TextModule.p14}>Войти</button>
                    <button className={TextModule.p14}>Мои Заказы</button>
                </div>
            </div>

            <div className={classes.card_img}>
                <img src={bgImage} alt={bgImage}/>
            </div>

        </div>
    );
};