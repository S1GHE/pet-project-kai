import React from 'react';
import HeaderStyle from '@src/features/Layout/section/header/Header.module.scss'
import {useClass} from "@src/shared/hooks";
import {TextModule} from "@src/shared/scss";

export const Header = () => {
  return (
    <div className={useClass([HeaderStyle.container, TextModule.p14])}>
      header
    </div>
  );
};