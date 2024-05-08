import {ContainerModule} from "@src/shared/scss";
import {LoginAccount} from "@src/widgets/cards";

export const Home = () => {
  return (
    <div className={ContainerModule.wrapper}>
        <LoginAccount/>
    </div>
  )
}
