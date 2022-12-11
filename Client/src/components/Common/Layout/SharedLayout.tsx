import React, { Fragment, useEffect } from 'react'
import { Outlet } from 'react-router-dom'
import Navbar from '../../layout/Navbar'

const SharedLayout = () => {
  return (
    <Fragment>
        <Navbar/>
        <Outlet/>
    </Fragment>
  )
}

export default SharedLayout