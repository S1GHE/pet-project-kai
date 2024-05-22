import {FC} from "react";
import classes from "@src/widgets/dropdown-catalog/style/DropDownCatalog.module.scss";
import Logo from "@src/shared/assets/icon/svg/logo.svg";

export const DropDownCatalog: FC = () => {
  return (
    <>
      <div className={classes.btn_logo}>
        <Logo/>
        <button>
          Каталог
        </button>
      </div>
    </>
  );
};