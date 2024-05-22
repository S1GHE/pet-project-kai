import React, {useEffect, useRef, useState} from 'react';
import HeaderStyle from '@src/features/layout/section/header/Header.module.scss'
import {useClass} from "@src/shared/hooks";
import {TextModule} from "@src/shared/scss";
import {HeaderBottom, HeaderTop} from "@src/widgets/header";

export const Header = () => {
  const headerTopRef = useRef<HTMLDivElement>(null)
  const [headerTopVisible, setHeaderTopVisible] = useState(true)

  useEffect(() => {
    const observer = new IntersectionObserver((entries) => {
      const entry = entries[0]
      setHeaderTopVisible(entry.isIntersecting)
    })
    observer.observe(headerTopRef.current)
  },[])

  return (
    <header className={useClass([HeaderStyle.container, TextModule.p14])}>
      <div ref={headerTopRef}>
        <HeaderTop/>
      </div>

      <div className={
        headerTopVisible ? HeaderStyle.headerStatic : HeaderStyle.headerFixed
      }>
        <HeaderBottom/>
      </div>
    </header>
  );
};