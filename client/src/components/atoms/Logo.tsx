import './Logo.css';

const LogoAtom = ({ src, alt, className }: any) => {
	return <img src={src} alt={alt} className={`logo ${className}`} />;
};

export default LogoAtom;
