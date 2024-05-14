import React from 'react'
import styles from "./Sidebar.module.css"
import {FaTimes}  from "react-icons/fa";
import { NavLink } from 'react-router-dom'

const Sidebar = ({ active }) => {

    const closeSidebar = () => {
        active(false)
    }

  return (
    <div className={styles.sidebar}>
        <FaTimes onClick={closeSidebar} className={styles.timesIcon} />
        <div className={styles.container}>
            <nav>
                <ul>
                    <NavLink className={styles.navlink} to="/equipmentlist"><li><span>Controle de equipamentos</span></li></NavLink>
                    <NavLink className={styles.navlink} to="/"><li><span>Lista de chamados</span></li></NavLink>
                </ul>
            </nav>
        </div>
    </div>
  )
}

export default Sidebar