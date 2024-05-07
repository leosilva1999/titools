import React from 'react'
import styles from "./Navbar.module.css"
import { NavLink } from 'react-router-dom'

const Navbar = () => {
  return (
    <nav className={styles.navbar}>
        <NavLink className={styles.brand} to="/">
            Aplac TI<p />
            <span>Tools</span>
        </NavLink>
    </nav>
  )
}

export default Navbar