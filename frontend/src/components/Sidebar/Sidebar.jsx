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
                    <li><NavLink className={styles.navlink} to="/equipmentlist"><span>Controle de equipamentos</span></NavLink></li>
                    <li><NavLink className={styles.navlink} to="/"><span>Lista de chamados</span></NavLink></li>
                </ul>
            </nav>
        </div>
    </div>
  )
}

export default Sidebar