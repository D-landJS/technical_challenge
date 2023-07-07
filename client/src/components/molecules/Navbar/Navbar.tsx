import { useEffect, useState } from 'react';
import Logo from '../../atoms/Logo';
import logo from '../../../assets/logo.png';
import movilLogo from '../../../assets/movil-logo.svg';
import './Navbar.css';

const Navbar = () => {
	const [isMobile, setIsMobile] = useState(window.innerWidth <= 768);

	useEffect(() => {
		const handleResize = () => {
			setIsMobile(window.innerWidth <= 768);
		};

		window.addEventListener('resize', handleResize);

		return () => {
			window.removeEventListener('resize', handleResize);
		};
	}, []);

	return (
		<nav className="navbar">
			<div className="navbar__container">
				<div className="navbar__logo">
					<Logo
						src={isMobile ? movilLogo : logo}
						alt="Logo"
						className={isMobile ? 'mobile-logo ' : ''}
					/>
				</div>
			</div>
		</nav>
	);
};

export default Navbar;
